using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CSharpPractice
{
    class LINQ
    {
        
        public LINQ()
        {
            using (var db = new DatabaseContext())
            {
                // select tweets whose authors are in the db more than once.
                var query = db.Tweets.GroupBy(e => e.tweetUserHandle).Where(grp => grp.Count() > 1).Select(grp => grp.Key);
                foreach (string item in query)
                {
                    Console.WriteLine(item);
                }
            }

        }
        
    }
}
