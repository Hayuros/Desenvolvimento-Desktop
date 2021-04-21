output: mcs.e mono.e clean
 
mcs.e:
	mcs Program.cs View/MenuCadastraCliente.cs View/MenuCadastraLocacao.cs View/MenuCadastraVeiculoLeve.cs View/MenuCadastraVeiculoPesado.cs View/Biblio/* -r:System.Windows.Forms.dll,System.Drawing.dll 
mono.e:
	mono Program.exe
 
clean:
	rm *.exe 