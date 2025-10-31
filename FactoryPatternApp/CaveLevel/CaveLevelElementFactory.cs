using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternApp.Common;

namespace FactoryPatternApp.CaveLevel
{
    public class CaveLevelElementFactory : LevelElementFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Goblin();
        }

        public override IWeapon CreateWeapon()
        {
            return new Axe();
        }

        public override IPowerUp CreatePowerUp()
        {
            return new Crystal();
        }
        public IEnemy? EmEnemy { get; set; }
        public IPowerUp ? PowerUp { get; set; }
        public IWeapon ? Weapon { get; set; }
        public override void SetupEnvironment()
        {
            PowerUp = CreatePowerUp();
            EmEnemy = CreateEnemy();
            Weapon = CreateWeapon();
        }
    }
}

    
