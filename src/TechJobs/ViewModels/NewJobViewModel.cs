using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Data;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class NewJobViewModel
    {
        [Required(ErrorMessage = "You must enter a name")]
        public string Name { get; set; }

        [Display(Name = "Employer")]
        public int EmployerID { get; set; }

        public int LocationID { get; set; }

        public int CoreCompetencyID { get; set; }

        public int PositionTypeID { get; set; }

        // TODO #3 - Included other fields needed to create a job,
        // with correct validation attributes and display names.

        //Use a list of SelectListItems for Employers (while not forgetting the getter and setter) and set that equal to a new list of SelectListItems
        //Use a list of SelectListItems for Locations (while not forgetting the getter and setter) and set that equal to a new list of SelectListItems
        //Use a list of SelectListItems for CoreCompetencies (while not forgetting the getter and setter) and set that equal to a new list of SelectListItems
        //Use a list of SelectListItems for PositionTypes (while not forgetting the getter and setter) and set that equal to a new list of SelectListItems
        //Actually this is already done down below?

        public List<SelectListItem> Employer { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Locations { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CoreCompetencies { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PositionTypes { get; set; } = new List<SelectListItem>();

        public NewJobViewModel()
        {

            JobData jobData = JobData.GetInstance();

            foreach (Employer field in jobData.Employers.ToList())
            {
                Employer.Add(new SelectListItem {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }

            foreach (Location field in jobData.Locations.ToList())
            {
                //use the add method effectively
                Locations.Add(new SelectListItem {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }

            foreach (CoreCompetency field in jobData.CoreCompetencies.ToList())
            {
                CoreCompetencies.Add(new SelectListItem
                {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }

            foreach (PositionType field in jobData.PositionTypes.ToList())
            {
                PositionTypes.Add(new SelectListItem
                {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }

            // TODO #4 - populate the other List<SelectListItem> 
            // collections needed in the view
            //create a 
            //public addsomething(string value){
            //Employers.Find}
        }
    }
}
