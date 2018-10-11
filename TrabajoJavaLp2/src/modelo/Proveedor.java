package modelo;
public class Proveedor{
        private long id_proveedor;
	private String ruc;
	private String razon_social;
	private String email;
	private String telefono;

        public Proveedor(){
            id_proveedor = 0;
            ruc = null;
            razon_social = null;
            email = null;
            telefono = null;
	}
        
        public Proveedor(long id_proveedor, String ruc, String razon_social, String email, String telefono) {
            this.id_proveedor = id_proveedor;
            this.ruc = ruc;
            this.razon_social = razon_social;
            this.email = email;
            this.telefono = telefono;
        }

        public long getId_proveedor() {
            return id_proveedor;
        }

        public void setId_proveedor(long id_proveedor) {
            this.id_proveedor = id_proveedor;
        }
        
	public void setRUC(String ruc){
		this.ruc = ruc;
	}

	public String getRUC(){
		return ruc;
	}

	public void setRazon_social(String razon_social){
		this.razon_social = razon_social;
	}

	public String getRazon_socual(){
		return razon_social;
	}

	public void setEmail(String email){
		this.email = email;
	}

	public String getEmail(){
		return email;
	}

	public void setTelefono(String telefono){
		this.telefono = telefono;
	}

	public String getTelefono(){
		return telefono;
	}
}