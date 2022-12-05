using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IFlightService : IService<Flight>
    {
        delegate int GetScore(Passenger passenger);
        /// <summary>
        /// retourne la liste des dates de vols pour une destination donnée
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        IList<DateTime> GetFlightDates(String destination);

        /// <summary>
        /// Affiche les vols en fonction de type de filtre et sa valeur
        /// </summary>
        /// <param name="filterType"></param>
        /// <param name="filterValue"></param>
        void GetFlights(string filterType, string filterValue);

        /// <summary>
        /// Affiche les dates et les destinations des vols d'un avion donné
        /// </summary>
        /// <param name="plane"></param>
        void ShowFlightDetails(Plane plane);
        /// <summary>
        /// retourne le nombre de vols programmés pour une semaine à partir d’une date donnée.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        int GetWeeklyFlightNumber(DateTime date);
        /// <summary>
        /// Retourne la moyenne de durées estimées des vols d'une destination donnée.
        /// </summary>
        /// <param name="Destination"></param>
        /// <returns></returns>
        double GetDurationAverage(String destination);
        /// <summary>
        /// Retourner les vols triés par ordre décroissant de leurs durées estimées.
        /// </summary>
        /// <returns></returns>
        IList<Flight> SortFlights();
        /// <summary>
        /// rETOURNER les trois passagers les plus âgés pour un vol donné.
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        IList<Passenger> GetThreeOlderTravellers(Flight flight);

        /// <summary>
        /// afficher les vols groupés par destination.
        /// </summary>
        void ShowGroupedFlights();
        /// <summary>
        /// une méthode de calcul de score, et renvoie le passager sénior.
        /// </summary>
        /// <param name="methode"></param>
        /// <returns></returns>
        Passenger GetSeniorPassenger(GetScore methode);

        //void Add(Flight flight);
        //void Delete(Flight flight);
        //IList<Flight> GetAll();



    }
}
