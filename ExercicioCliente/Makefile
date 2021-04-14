output: mcs.e mono.e clean
 
mcs.e:
	mcs Program.cs MenuCadastraCliente.cs -r:System.Windows.Forms.dll,System.Drawing.dll 
mono.e:
	mono Program.exe
 
clean:
	rm *.exe