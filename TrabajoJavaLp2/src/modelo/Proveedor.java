package modelo;
public class Proveedor{
	private String ruc;
	private String razon_social;
	private String email;
	private String telefono;

	public Proveedor(){
		ruc = null;
		razon_social = null;
		email = null;
		telefono = null;
	}

	public Proveedor(String ruc, String razon_social, String email, String telefono){
		setRUC(ruc);
		setRazon_social(razon_social);
		setEmail(email);
		setTelefono(telefono);
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