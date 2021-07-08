class Account:
    id = int;
    name = str;
    document = str;
    email = str;
    password = str;  

## Métodos mágicos: Son llamados automaticamente y estrictamente bajo ciertas reglas.
## El método constructor en Python forma parte de esta familia de métodos y como aprendimos en la clase anterior lo declaramos usando __init__

    def __init__(self, name, document):
        self.name       = name
        self.document   = document