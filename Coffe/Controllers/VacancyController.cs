using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Internal;

namespace Coffe.Controllers
{
    public class VacancyController : Controller
    {
        private readonly DataContext _context;
        private MainInfo _mainInfo;

        public VacancyController(DataContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CareerViewModel cvm)
        {


            if (!ModelState.IsValid)
            {
                return View(cvm);
            }
            
            if (cvm.Married == null)
            {
                ModelState.AddModelError("Ailə vəziyyəti", "Zəhmət olmasa ailə vəziyətinizi seçin");
                return View(cvm);
            }

            
            _mainInfo = new MainInfo()
            {
                Firstname = cvm.Firstname,
                Lastname = cvm.Lastname,
                BirthDay = cvm.BirthDay,
                BirthMonth = cvm.BirthMonth,
                BirthYear = cvm.BirthYear,
                BirthCity = cvm.BirthCity,
                isArmy = cvm.isArmy,
                isCar = cvm.isCar,
                Married = cvm.Married,
                HomeNumber = cvm.HomeNumber,
                MobileNumber = cvm.MobileNumber,
                OthersNumber = cvm.OthersNumber,
                Email = cvm.Email,
                Address = cvm.Address,
                DriverLicense = cvm.DriverLicense,
                isPreviousJob = cvm.isPreviousJob,
                PositionApply = cvm.PositionApply,
                VacancyInfo = cvm.VacancyInfo,
                GuaranteeName = cvm.GuaranteeName,
                GuaranteeCompany = cvm.GuaranteeCompany,
                GuaranteePosition = cvm.GuaranteePosition,
                GuaranteeNumber = cvm.GuaranteeNumber,
                OthersInfo = cvm.OthersInfo
            };
            
            await _context.MainInfos.AddAsync(_mainInfo);
            await _context.SaveChangesAsync();

            for (int i = 0; i < cvm.EducationUniName.Count(); i++)
            {
                for (int j = 0; j < cvm.EducationDate.Count(); j++)
                {
                    if (i == j)
                    {
                        for (int k = 0; k < cvm.EducationSpeciality.Count(); k++)
                        {
                            if (i == k)
                            {
                                for (int l = 0; l < cvm.EducationDegree.Count(); l++)
                                {
                                    if (l == i)
                                    {
                                        Education education = new Education()
                                        {
                                            UniName = cvm.EducationUniName.ElementAt(i),
                                            EducationDate = cvm.EducationDate.ElementAt(j),
                                            Degree = cvm.EducationDegree.ElementAt(k),
                                            Speciality = cvm.EducationSpeciality.ElementAt(k),
                                            MainInfoId = _mainInfo.Id
                                        };
                                        await _context.Educations.AddRangeAsync(education);
                                        await _context.SaveChangesAsync();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cvm.ComputerCourseName.Count(); i++)
            {
                for (int j = 0; j < cvm.CoumputerDegree.Count(); j++)
                {
                    if (i == j)
                    {
                        Computer computer = new Computer()
                        {
                            Name = cvm.ComputerCourseName.ElementAt(i),
                            Degree = cvm.CoumputerDegree.ElementAt(j),
                            MainInfoId = _mainInfo.Id
                        };
                        await _context.Computers.AddRangeAsync(computer);
                        await _context.SaveChangesAsync();
                    }
                }
            }

            for (int i = 0; i < cvm.ExperienceCompany.Count(); i++)
            {
                for (int j = 0; j < cvm.ExperienceSalary.Count(); j++)
                {
                    if (i == j)
                    {
                        for (int k = 0; k < cvm.ExperienceLeftJob.Count(); k++)
                        {
                            if (i == k)
                            {
                                for (int l = 0; l < cvm.ExperienceWorkedDay.Count(); l++)
                                {
                                    if (i == l)
                                    {
                                        for (int m = 0; m < cvm.ExperiencePositionAbout.Count(); m++)
                                        {
                                            if (i == m)
                                            {
                                                for (int n = 0; n < cvm.ExperienceWorkedMonth.Count(); n++)
                                                {
                                                    if (i == n)
                                                    {
                                                        for (int o = 0; o < cvm.ExperienceWorkedYear.Count(); o++)
                                                        {
                                                            if (o == i)
                                                            {
                                                                for (int p = 0; p < cvm.ExperienceWorkNumber.Count(); p++)
                                                                {
                                                                    if (i == p)
                                                                    {
                                                                        Experience experience = new Experience()
                                                                        {
                                                                            Company = cvm.ExperienceCompany.ElementAt(i),
                                                                            Salary = cvm.ExperienceSalary.ElementAt(j),
                                                                            LeftJob = cvm.ExperienceLeftJob.ElementAt(k),
                                                                            WorkedDay = cvm.ExperienceWorkedDay.ElementAt(l),
                                                                            PositionAbout = cvm.ExperiencePositionAbout.ElementAt(m),
                                                                            WorkedMonth = cvm.ExperienceWorkedMonth.ElementAt(n),
                                                                            WorkedYear = cvm.ExperienceWorkedYear.ElementAt(o),
                                                                            WorkNumber = cvm.ExperienceWorkNumber.ElementAt(p),
                                                                            MainInfoId = _mainInfo.Id
                                                                        };
                                                                        await _context.Experiences.AddRangeAsync(experience);
                                                                        await _context.SaveChangesAsync();
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cvm.LangName.Count(); i++)
            {
                for (int j = 0; j < cvm.Read.Count(); j++)
                {
                    if (i == j)
                    {
                        for (int k = 0; k < cvm.Write.Count(); k++)
                        {
                            if (i == k)
                            {
                                for (int l = 0; l < cvm.Understood.Count; l++)
                                {
                                    if (i == l)
                                    {
                                        Languange languange = new Languange()
                                        {
                                            LangName = cvm.LangName.ElementAt(i),
                                            Read = cvm.Read.ElementAt(j),
                                            Write = cvm.Write.ElementAt(k),
                                            Understood = cvm.Understood.ElementAt(l),
                                            MainInfoId = _mainInfo.Id
                                        };
                                        await _context.Languanges.AddRangeAsync(languange);
                                        await _context.SaveChangesAsync();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            TempData["success"] = "CV-niz uğurla göndərildi";
            return View();
        }

    }
}