using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfRü_prg_2020_T1_F2_csudh.edu
{
    class DNSRecord
    {
        public string Domain { get; private set; }
        public string IP { get; private set; }

        public DNSRecord(string sor)
        {
            string[] tmp = sor.Split(';');
            Domain = tmp[0];
            IP = tmp[1];
        }
        
        //4. feladat
        public string SubDomain(int Index)
        {
            string[] SubDomains = Domain.Split('.');
            return (Index > SubDomains.Length) ? "nincs" : SubDomains[SubDomains.Length - Index];
        }
    }
}
