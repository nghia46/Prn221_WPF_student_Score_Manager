using Microsoft.EntityFrameworkCore;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewDataTO.Service
{
    public class ScoreDataStatisticsService : ServiceBase<ScoreDataStatistics>
    {
        public ScoreDataStatisticsService() : base()
        {
            // You don't need to add anything specific to the constructor for now
        }

        public List<ScoreDataStatistics> GetScoreStatistics()
        {
            return _dbSet
                .GroupBy(stat => stat.Year)
                .Select(g => new ScoreDataStatistics
                {
                    Year = g.Key,
                    StudentCountAtThisYear = g.Count(),
                    CountToan = g.Count(stat => stat.CountToan != null),
                    CountVan = g.Count(stat => stat.CountVan != null),
                    CountLy = g.Count(stat => stat.CountDiaLy != null),
                    CountSinh = g.Count(stat => stat.CountSinh != null),
                    CountNgoaiNgu = g.Count(stat => stat.CountNgoaiNgu != null),
                    CountHoa = g.Count(stat => stat.CountHoa != null),
                    CountLichSu = g.Count(stat => stat.CountLichSu != null),
                    CountDiaLy = g.Count(stat => stat.CountDiaLy != null),
                    CountGDCD = g.Count(stat => stat.CountGDCD != null)
                })
                .ToList();
        }
    }
}
