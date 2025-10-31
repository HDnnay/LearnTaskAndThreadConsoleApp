using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Common
{
    public abstract class LevelElementFactory
    {
        public abstract IEnemy CreateEnemy();
        public abstract IWeapon CreateWeapon();
        public abstract IPowerUp CreatePowerUp();
        public IEnemy? Enemy { get; set; }
        public IWeapon? Weapon { get; set; }
        public IPowerUp? PowerUp { get; set; }

        public abstract void SetupEnvironment();
    }
}
    