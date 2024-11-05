﻿/*
Fecha de Creacion: 27-10-2024
Autor: Roberto Alexander Toloza 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMicro.Domain.Modelo
{
    public class Rol: BaseEntity
    {
        public string nombreRol {  get; set; }
        public string descripcionRol { get; set; }

        //hace referencia a que un rol puede tener un coleccion de usuarios
        // Colección de la relación N a N
        public ICollection<Rol_Permiso> RolPermiso { get; set; } = new List<Rol_Permiso>();

        public ICollection<ProyectoUsuarioRol> ProyectoUsuarioRols { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
