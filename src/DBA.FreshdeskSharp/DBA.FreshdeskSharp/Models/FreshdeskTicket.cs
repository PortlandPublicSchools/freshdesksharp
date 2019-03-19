using System.Collections.Generic;
using Newtonsoft.Json;

namespace DBA.FreshdeskSharp.Models
{
    public class FreshDeskTicketWrapper<T> where T :  class
    {
        [JsonProperty("tickets")]
        public List<FreshdeskTicket<T>> Tickets { get; set; }
    }

    public class FreshdeskTicket : FreshdeskTicket<FreshdeskCustomFields>
    {
        public FreshdeskTicket()
        {
            CustomFields = new FreshdeskCustomFields();
        }
    }

    public class FreshdeskTicket<TCustomFieldObject> : FreshdeskTicketBase, IFreshdeskCustomFields<TCustomFieldObject> where TCustomFieldObject : class
    {
        public TCustomFieldObject CustomFields { get; set; }
    }
}
