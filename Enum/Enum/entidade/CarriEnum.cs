using Enum.enums;

namespace Enum.entidade;

public class CarriEnum
{
    public CarriEnum()
    {
        Cor = Cores.AZUL;
    }
    
    private Cores cor;

    public Cores Cor
    {
        get { return cor; }
        set { cor = value; }
    }
}

/*namespace Enum.entidade;

public class CarriEnum
{
    private Cores cor;

    public Cores Cor
    {
        get => cor; // Getter simplificado
        set => cor = value; // Setter simplificado
    }
}
*/