﻿using InstantDelivery.Domain.Entities;
using InstantDelivery.Services.Paging;

namespace InstantDelivery.Services
{
    /// <summary>
    /// Interfejs warstwy serwisu pracowników
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Dodaje pracownika do bazy danych
        /// </summary>
        /// <param name="employee"></param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Zwraca stronę z pracownikami
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        PagedResult<Employee> GetPage(PageQuery<Employee> query);

        /// <summary>
        /// Wczytuje dane pracownika z bazy danych, ignorując wprowadzone zmiany
        /// </summary>
        /// <param name="employee"></param>
        void Reload(Employee employee);

        /// <summary>
        /// Usuwa pracownika z bazy danych
        /// </summary>
        /// <param name="employee"></param>
        void RemoveEmployee(Employee employee);

        /// <summary>
        /// Zapisuje aktualny stan kontekstu
        /// </summary>
        void Save();

        /// <summary>
        /// Zmienia pojazd przypisany do pracownika
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="selectedVehicle"></param>
        void ChangeEmployeesVehicle(Employee employee, Vehicle selectedVehicle);
    }
}