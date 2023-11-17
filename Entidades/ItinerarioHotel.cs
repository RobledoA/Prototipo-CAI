namespace Prototipo_CAI;

public class ItinerarioHotel
{
    public Disponibilidad Disponibilidad { get; set; } //lo que el hotel tiene disponible.
    public DateTime Desde { get; set; } //lo que "yo" quiero reservar.
    public DateTime Hasta { get; set; }
}
