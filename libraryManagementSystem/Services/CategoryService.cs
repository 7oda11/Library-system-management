using libraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Services
{
    public static class CategoryService
    {
        public static LibraryDbContext LibraryDbContext = new LibraryDbContext();

        static CategoryService()
        {
            
        }
        public static List<Category> GetCategories() {
            return LibraryDbContext.Categories.ToList();    
        }
    }
}
