using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;  
using Employee_Relation.Models;

namespace Employee_Relation.Controllers;

public class LoginController : Controller  
{
       private readonly ACE42023Context db=new ACE42023Context();  
       public LoginController(ACE42023Context _db)
       {
              db=_db;      
       }
       public IActionResult Login()
       {
              ViewData["Message"]="";
              ViewData["PrevPage"]=HttpContext.Session.GetString("PrevPage");
              Console.WriteLine(ViewData["PrevPage"]);
              return View();
       }
       [HttpPost]
       public IActionResult Login(Usertbl user)      
       {
              Usertbl obj=null;
              bool IsUserIdfound=false;
              bool IsPasswordfound=false;
              HttpContext.Session.SetString("PrevPage","Login");  
              foreach(var User in db.Usertbls)
              {
                      if(User.UserId==user.UserId && User.Password==user.Password)  
                      {
                         obj=User;
                         break;
                      }
                      if(User.UserId==user.UserId)       
                      {
                         IsUserIdfound=true;
                      }
                      if(User.Password==user.Password)    
                      {
                         IsPasswordfound=true;
                      }
              }
              if(obj!=null)
              {
                 HttpContext.Session.SetString("Username",obj.UserName); 
                 return RedirectToAction("Index","Home");   
              }
              else
              {
                 ViewData["Message"]=(IsUserIdfound&&!IsPasswordfound)?"Password Is Incorrect":((IsPasswordfound&&!IsUserIdfound)?"UserId Is Not Found":"User With Givern UserId and Password Is Not Found,Please Enter Correct Credentials.");  
              }
              return View();  
       }
       public IActionResult Register()
       {
              ViewData["Message"]="";
              return View();
       }
       [HttpPost]
       public IActionResult Register(Usertbl user)       
       {
              foreach(var User in db.Usertbls)
              {
                     string username=User.UserName;
                     if(username.Length>=user.UserName.Length)
                     {
                        username=username.Substring(0,user.UserName.Length);  
                     }
                     if(User.UserId==user.UserId)
                     {
                        ViewData["Message"]=$"User With {User.UserId} UserId Already Exist";  
                        return View();
                     }
                     if(username==user.UserName)  
                     {
                        ViewData["Message"]=$"{User.UserName} UserName Already Exist";    
                        return View();
                     }
                     if(User.Password==user.Password)
                     {
                        ViewData["Message"]=$"Given Password Already Exist";   
                        return View();
                     }
              }
              db.Usertbls.Add(user);
              db.SaveChanges();  
              HttpContext.Session.SetString("PrevPage","Register");  
              return RedirectToAction("Login","Login");  
       }
       public IActionResult Logout()
       {
              HttpContext.Session.Remove("Username");
              HttpContext.Session.SetString("PrevPage","Logout");
              return RedirectToAction("Index","Home");  
       }
       
}