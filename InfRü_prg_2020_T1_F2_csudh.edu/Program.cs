using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfRü_prg_2020_T1_F2_csudh.edu
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<DNSRecord> DNSRecords = new List<DNSRecord>();
            foreach (var sor in File.ReadAllLines("csudh.txt").Skip(1))
            {
                DNSRecords.Add(new DNSRecord(sor));
            }

            //3.
            Console.WriteLine($"3. feladat: Domainek száma: {DNSRecords.Count}");

            //5. feladat
            const int oszlopokSzáma = 5;
            Console.WriteLine("Az első domain felépítése: ");
            for (int i = 1; i <= oszlopokSzáma; i++)
                Console.WriteLine($"\t{i}. szint: {DNSRecords.First().SubDomain(i)}");

            // 6. feladat
            List<string> table = new List<string>();

            table.Add("<table>");
            table.Add("<tr>");
            table.Add("<th style='text-align: left'>Ssz</th>");
            table.Add("<th style='text-align: left'>Host domainneve</th>");
            table.Add("<th style='text-align: left'>Host IP címe</th>");

            for (int i = 1; i <= oszlopokSzáma; i++)
                table.Add($"<th style='text-align: left'>{i}. szint</th>");

            table.Add("</tr>");

            for (int i = 0; i < DNSRecords.Count; i++)
            {
                table.Add("<tr>");
                table.Add($"<th style='text-align: left'>{i + 1}.</th>");
                table.Add($"<td>{DNSRecords[i].Domain}</td>");
                table.Add($"<td>{DNSRecords[i].IP}</td>");
                for (int j = 1; j <= oszlopokSzáma; j++)
                    table.Add($"<td>{DNSRecords[i].SubDomain(j)}</td>");
                table.Add("</tr>");
            }

            table.Add("</table>");
            File.WriteAllLines("table.html", table);

            Console.ReadKey();
        }
    }
}
