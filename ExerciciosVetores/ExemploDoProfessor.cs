using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class ExemploDoProfessor
    {
        public void Executar()
        {
            var table = new ConsoleTable("Código", "Descrição", "Preço");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.AddRow(8002, "Cachaça", "5,00");
            table.Write();
        }
    }
}
