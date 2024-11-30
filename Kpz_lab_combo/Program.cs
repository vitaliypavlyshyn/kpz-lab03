
using Kpz_lab_combo.DataBase;
using Kpz_lab_combo.Models;

public class Program()
{
    public static void Main()
    {
        using (var context = new HistoricalEventDbContext())
        {
            var historicalEvent = new HistoricalEventEntity()
             {
                 Id = 1,
                 Name = "Помаранчева революція",
                 Description =
                     "Кампанія протестів, мітингів, пікетів, страйків та інших актів громадянської непокори в Україні, організована і проведена прихильниками Віктора Ющенка, основного кандидата від опозиції на президентських виборах у листопаді — грудні 2004 року, після оголошення Центральною виборчою комісією попередніх результатів, згідно з якими нібито переміг його суперник — Віктор Янукович.",
                 StartDate = new DateOnly(2004, 11, 22),
                 EndDate = new DateOnly(2005, 01, 23),
                 Reasons = new List<ReasonEntity>(),
                 Consequence = new List<ConsequenceEntity>()
             };
             context.HistoricalEvents.Add(historicalEvent); 
             context.SaveChanges();
         }
         
     }
 }