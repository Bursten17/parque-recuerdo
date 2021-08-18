using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Application.Contracts.Request.CRM.Opportunity
{
    public class OpportunityRequest
    {
        public int OPPORTUNITY_ID { get; set; }
        public string OPPORTUNITY_NAME { get; set; }
        public string OPPORTUNITY_DETAILS { get; set; }
        public string OPPORTUNITY_STATE { get; set; }
        public int RESPONSIBLE_USER_ID { get; set; }
        public int CATEGORY_ID { get; set; }
        public string IMAGE_URL { get; set; }
        public string BID_CURRENCY { get; set; }
        public int BID_AMOUNT { get; set; }
        public string BID_TYPE { get; set; }
        public int BID_DURATION { get; set; }
        public string ACTUAL_CLOSE_DATE { get; set; }
        public string DATE_CREATED_UTC { get; set; }
        public string DATE_UPDATED_UTC { get; set; }
        public int OPPORTUNITY_VALUE { get; set; }
        public int PROBABILITY { get; set; }
        public string FORECAST_CLOSE_DATE { get; set; }
        public int OWNER_USER_ID { get; set; }
        public string LAST_ACTIVITY_DATE_UTC { get; set; }
        public string NEXT_ACTIVITY_DATE_UTC { get; set; }
        public int PIPELINE_ID { get; set; }
        public int STAGE_ID { get; set; }
        public int CREATED_USER_ID { get; set; }
        public int ORGANISATION_ID { get; set; }
        public CustomFieldsRequest CUSTOMFIELDS { get; set; }
        public TagsRequest TAGS { get; set; }
        public LinkRequest LINK {get; set;}
    
    }
}
