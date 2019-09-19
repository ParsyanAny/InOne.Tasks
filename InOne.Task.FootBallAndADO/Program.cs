using InOne.Task.FootBallAndADO.ModelRepositories;
using InOne.Task.FootBallAndADO.Models;
using InOne.Task.FootBallAndADO.PrintExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task.FootBallAndADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            var dbContext = new DbContext(conStr);

            #region Teams Test
            TeamRepository teamRepo = new TeamRepository(dbContext);
            IEnumerable<Team> teams = teamRepo.SelectAll();
            teams.PrintTeam();
            #endregion

            #region Players Test
            //PlayerRepository playerRepo = new PlayerRepository(dbContext);
            //IEnumerable<Player> players = playerRepo.SelectAll();
            //players.PrintPlayer();
            #endregion

            #region Coachs Test
            //CoachRepository coachRepo = new CoachRepository(dbContext);
            //IEnumerable<Coach> coachs = coachRepo.SelectAll();
            ////coachRepo.Insert(new Coach { FullName = "Test1"});
            ////Coach test = new Coach {Id = 10, FullName = "Momo"};
            ////coachRepo.Update(test);
            ////coachRepo.Delete(10);
            ////coachRepo.Delete(11);
            //coachs.PrintCoach();
            #endregion

            #region BrandNames Test
            //BrandNamesRepository brandname = new BrandNamesRepository(dbContext);
            //IEnumerable<BrandName> brandnames = brandname.SelectAll();
            //brandnames.PrintBrandNames();
            #endregion

            #region Shoes Test
            //ShoesRepository shoes = new ShoesRepository(dbContext);
            //IEnumerable<Shoes> shoesE = shoes.SelectAll();
            //shoesE.PrintShoes();
            #endregion

            Console.ReadLine();
        }
    }
}
