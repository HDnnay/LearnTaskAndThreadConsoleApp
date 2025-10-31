using FactoryPatternApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.HouseLevel
{
    public class HouseLevelElementFactory: LevelElementFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Ghost();
        }

        public override IWeapon CreateWeapon()
        {
            return new Staff();

        }

        public override IPowerUp CreatePowerUp()
        {
            return new Orb();
        }

        public override void SetupEnvironment()
        {
            CreatePowerUp();
            CreateEnemy();
            CreateWeapon();
        }
    }
}
