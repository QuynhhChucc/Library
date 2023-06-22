using Library.Data;
using Microsoft.AspNetCore.Mvc;

namespace Library.Models
{
	public class Sidebar: ViewComponent
	{
		private readonly LibraryContext _context;

		public Sidebar(LibraryContext context)
		{
			_context = context;  
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
