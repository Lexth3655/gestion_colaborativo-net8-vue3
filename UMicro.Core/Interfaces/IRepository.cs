﻿/*
Fecha de Creacion: 29-10-2024
Autor: Roberto Alexander Toloza 
Implementacion de patron de repositorio utilizando un repositorio generico
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UMicro.Domain.Modelo;
using UMicro.Core.Interfaces;


namespace UMicro.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(); // Retorna IQueryable<T> en lugar de IEnumerable<T>
        Task<List<T>> GetAllAsync(); // También puedes mantener este para casos específicos
        IEnumerable<T> GetAllE(); // mostrar todo para comparar
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<bool> DeleteAsync(T t);
        Task<IEnumerable<Proyecto>> GetProyectosDeUsuarioAsync(int usuarioId);
      //Task<bool> ExistsAsync(Func<object, bool> value);
        Task GetUsuariosByProyectoIdAsync(int proyectoId);
        Task ObtenerPorUsuarioYProyectoAsync(int usuarioID, int proyectoID);
    }


}

