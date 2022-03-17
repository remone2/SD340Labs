using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneNumbers;
using SD340Labs.Models;

namespace SD340Labs.Controllers
{
    public class PhoneController : Controller
    {
        private static PhoneNumberUtil _phoneUtil;

        public PhoneController()
        {
            _phoneUtil = PhoneNumberUtil.GetInstance();
        }

        // GET: PhoneController
        public ActionResult Check()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Check(PhoneNumberCheckViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Parse the number to check into a PhoneNumber object.
                    PhoneNumber phoneNumber = _phoneUtil.Parse(model.PhoneNumberRaw,
                        model.CountryCodeSelected);
                    ModelState.FirstOrDefault(x => x.Key == nameof(model.Valid)).Value.RawValue =
                        _phoneUtil.IsValidNumberForRegion(phoneNumber, model.CountryCodeSelected);
                    ModelState.FirstOrDefault(x => x.Key == nameof(model.HasExtension)).Value.RawValue
                        = phoneNumber.HasExtension;
                    return View(model);
                }
                catch (NumberParseException npex)
                {
                    ModelState.AddModelError(npex.ErrorType.ToString(), npex.Message);
                }
            }
            ModelState.SetModelValue(nameof(model.CountryCodeSelected),
                model.CountryCodeSelected, model.CountryCodeSelected);
            ModelState.SetModelValue(nameof(model.PhoneNumberRaw),
                model.PhoneNumberRaw, model.PhoneNumberRaw);

            ModelState.SetModelValue(nameof(model.Valid), false, null);
            model.Valid = false;
            ModelState.SetModelValue(nameof(model.HasExtension), false, null);
            model.HasExtension = false;

            return View(model);
        }

        // GET: PhoneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhoneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhoneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhoneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
