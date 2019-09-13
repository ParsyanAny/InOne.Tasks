using System;

namespace InOne.Task.FootBallAndADO.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int BrandName_Id { get; set; }
        public int Player_Id { get; set; }
    }
}
