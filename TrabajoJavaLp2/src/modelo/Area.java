package modelo;
public class Area{
	private long idArea;
	private String nombreArea;

    

	public Area(){
            idArea = 0;
            nombreArea = null;
	}
	public Area(long idArea, String nombreArea){
            this.idArea = idArea;
            this.nombreArea = nombreArea;
	}
        
        public long getIdArea() {
            return idArea;
        }

        public void setIdArea(long idArea) {
            this.idArea = idArea;
        }

        public String getNombreArea() {
            return nombreArea;
        }

        public void setNombreArea(String nombreArea) {
            this.nombreArea = nombreArea;
        }
}