using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    public class JsonRepos : IRepos
    {
        public List<PoklZaznam> NactiVse()
        {
            throw new NotImplementedException();
        }

        public PoklZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam Vytvorzaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
