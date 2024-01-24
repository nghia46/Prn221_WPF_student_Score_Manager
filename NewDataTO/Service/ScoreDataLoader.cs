using NewDataTO;
using NewDataTO.Model;


public class ScoreDataLoader
{
    private readonly OtherOtherDatabaseContext _context;

    public ScoreDataLoader(OtherOtherDatabaseContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public List<ScoreDataStatistics> LoadStatistics()
    {
        var statistics = _context.ScoreDataModels
            .GroupBy(score => score.Year)
            .Select(g => new ScoreDataStatistics
            {
                Year = g.Key,
                StudentCountAtThisYear = g.Count(),
                CountToan = g.Count(score => score.Toan != null),
                CountVan = g.Count(score => score.Van != null),
                CountLy = g.Count(score => score.Ly != null),
                CountSinh = g.Count(score => score.Sinh != null),
                CountNgoaiNgu = g.Count(score => score.NgoaiNgu != null),
                CountHoa = g.Count(score => score.Hoa != null),
                CountLichSu = g.Count(score => score.LichSu != null),
                CountDiaLy = g.Count(score => score.DiaLy != null),
                CountGDCD = g.Count(score => score.GDCD != null)
            })
            .ToList();

        return statistics;
    }
}
