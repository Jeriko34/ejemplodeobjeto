using Miacuario;
delfin d1 = new delfin();
d1.Nombre = "Jeriko";
delfin d2 = new delfin();
d2.Nombre = "Alejandro";
orca o1 = new orca();
o1.Nombre = "Sebastian";

acuario a1 = new acuario();
a1.Direccion = "Av Breña";

a1.delfin1 = d1;
a1.delfin2 = d2;
a1.orca1 = o1;
Console.WriteLine(a1.Direccion);
a1.listaNombre();
d1.Nadar();
o1.Saltar();
Console.ReadKey();
