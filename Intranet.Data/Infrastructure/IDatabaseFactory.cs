﻿using Intranet.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intranet.Data.Infrastructure

{
    public interface IDatabaseFactory : IDisposable
    {
        // instancié l'objet Context
        IntranetContext DataContext { get; }
    }

    //1er principe
    //Séparation des Conceptes (SoC)

    // 2eme principe
    // Principe de responsabilité unique (SRP)
    //- chaque objet doit avoir une responsabilité unique,
    //et que tous ses services doit être étroitement aligné avec cette responsabilité.
}
