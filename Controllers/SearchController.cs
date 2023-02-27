using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee_Relation.Models;
using Microsoft.AspNetCore.Http;  
namespace Employee_Relation.Controllers;

public class SearchController : Controller  
{
       private readonly ACE42023Context db=new ACE42023Context();  
       public SearchController(ACE42023Context _db)
       {
              db=_db;
       }
       public IActionResult GetEmployee(IFormCollection f)
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");   
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Login","Login");    
              }
              var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");  
              var url = location.AbsoluteUri;  
              HttpContext.Session.SetString("url",url);
              string keyword=f["keyword"].ToString();
              var result=db.Emps.Where(x=>x.Ename.Contains(keyword)).ToList();   
              return View(result);
       }
       [Route("GetDetails1/{id:int}")]
       public IActionResult Details(int id)  
       {      
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);    
       }
       [Route("Edit1/{id:int}")]  
       public IActionResult Edit(int id)
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");     
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)  
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);  
       }
       [HttpPost]
       [Route("Edit1/{id:int}")]
       public IActionResult Edit(Emp emp)  
       {
              foreach(var team in db.Teams)
              {
                      if(team.TeamName==emp.TeamName)   
                      {
                         emp.TeamLead=team.TeamLead;   
                      }
              }
              if(emp.Awards==null)
              {
                 emp.Awards="None";  
              }
              db.Emps.Update(emp);  
              db.SaveChanges();  
              Console.WriteLine(HttpContext.Session.GetString("url"));   
              return RedirectToAction("ShowEmployee","Employee");  
       }
       public IActionResult Delete(int id)  
       {
              ViewData["Username"]=HttpContext.Session.GetString("Username");  
              if(ViewData["Username"]==null)
              {
                 return RedirectToAction("Index","Home");  
              }  
              Emp Curr_Emp=null;
              foreach(var emp in db.Emps)
              {
                      if(emp.Eid==id)
                      {
                         Curr_Emp=emp;
                         break;
                      }
              }
              return View(Curr_Emp);  
       }
       [HttpPost]
       public IActionResult remove(Emp emp)
       {
              db.Emps.Remove(emp);
              db.SaveChanges();
              return RedirectToAction("ShowEmployee","Employee");  
       }

}