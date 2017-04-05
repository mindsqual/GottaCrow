using GottaCrowWebUI.Utilities;
using System;
using System.ComponentModel.DataAnnotations;

namespace GottaCrowWebUI.Entities
{
    #region// Interfaces, Enums
    public enum JobSearchActivityType
    {
        Networking,
        JobBoardSearch,
        PhoneCall,
        JobFairAttend,
        CvUpdate,  // this includes working on resume, coverletter, seeing a job coach, etc.
        ApplyForPosition,  //resume submitted and initial application if required.
        PhoneScreen,
        InPersonInterview
    }

    public enum MeansOfContact
    {
        Phone,
        Email,
        GroundMail,
        SocialMedia,
    }

    public interface IJobSearchActivity
    {
        int Id { get; set; }
        DateTime HappenedOn { get; set; } //actually the creatin date.
        JobSearchActivityType ActivityType { get; set; }

    }
    #endregion// abstract, interfaces, enums

    #region// concrete classes
    /// <summary>
    /// Any activity 
    /// that contributes to the job search.
    /// </summary>
    public class JobSearchActivity : IJobSearchActivity
    {
        public int Id { get; set; }

        public JobSearchActivityType ActivityType { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime HappenedOn { get; set; }

        public IContact Contact { get; set; }
    }
    #endregion
}
