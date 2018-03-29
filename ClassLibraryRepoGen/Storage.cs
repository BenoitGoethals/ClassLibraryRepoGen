using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRepoGen.model;

namespace ClassLibraryRepoGen
{
   public class Storage<T> where T:Item
    {
       private ISet<T> _set=new SortedSet<T>(Item.NameComparer);

        public void Add(T t)
        {
            _set.Add(t);
        }

        public void Add(params T[] list)
        {
            foreach (var t in list)
            {
                _set.Add(t);
            }
        }


        public List<T> All()
        {
            return _set.ToList();
        }
     //  employees = empList.FindAll((e) => { return (e.FirstName.Contains("J")); });

    public List<T> Predicate(Predicate<T> func)
    {
        return _set.ToList().FindAll(func);
    }
    public int Count()
        {
            return _set.Count();
        }


        public List<T> Age(int age)
        {
            return _set.Where(x => x.Age==age).ToList();
        }


        public override string ToString()
        {
            return $"{nameof(_set)}: {_set}";
        }
    }
}
