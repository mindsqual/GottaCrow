using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Model
{
    public enum ActivityType
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
}
