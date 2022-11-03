using Crud_Operation.Data;
using Crud_Operation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation.Controllers
{
    public class VenderMasterController : Controller
    {
        private readonly AppDBContextClass context;

        public VenderMasterController(AppDBContextClass _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var vender = context.venderMasters.ToList();
            return View(vender);
        }
        [HttpGet]
        public IActionResult AddVender(int id)
        {
            if (id == 0)
            {
                return View();
            }
            else {
                var vander = context.venderMasters.FirstOrDefault(x => x.Id == id);
                return View(vander);
            }
            

        } 
        [HttpPost]  
        public IActionResult AddVender(VenderMaster vender)
        {

            var vandermaster = context.venderMasters.Find(vender.Id);
            if (vandermaster != null)
            {
                vandermaster.VenderName = vender.VenderName;
                vandermaster.CompanyName = vender.CompanyName;
                vandermaster.Email = vender.Email;
                vandermaster.MobileNo = vender.MobileNo;
                vandermaster.Address = vender.Address;
                vandermaster.Pincode = vender.Pincode;
                context.SaveChanges();
                return RedirectToAction("Index");
               
            }
            else
            {
                var vander = new VenderMaster()
                {
                    VenderName = (vender.VenderName),
                    CompanyName = vender.CompanyName,
                    Email = vender.Email,
                    MobileNo = vender.MobileNo,
                    Address = vender.Address,
                    Pincode = vender.Pincode,
                    Status = true
                };
                context.venderMasters.Add(vander);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(VenderMaster venderMaster)
        {
            var vender = context.venderMasters.Find(venderMaster.Id);
            if (vender != null) {
                context.venderMasters.Remove(vender);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }





    }
}
