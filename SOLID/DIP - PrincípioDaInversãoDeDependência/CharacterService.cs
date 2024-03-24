using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP___PrincípioDaInversãoDeDependência
{
    public class CharacterService
    {
        public void CreatedCharacterMario(Mario mario)
        {
            // lógica para criar o personagem
        }

        public void CreatedCharacterMario(ICharacter character)
        {
            // lógica para criar o personagem sem acoplamento
        }
    }
}
