using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationBilling.Models.DTO;

namespace WebApplicationBilling.Models.ViewModels
{
    public class CusomersVM
    {
        public IEnumerable<SelectListItem> ListrCustomers { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}
