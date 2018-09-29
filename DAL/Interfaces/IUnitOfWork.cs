using System;
using DAL.Models;


namespace DAL.Interfaces
{
    /// <summary>
    /// Unit of work provides access to repositories.  Operations on multiple repositories are atomic through
    /// the use of Commit().
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        RandaDBContext DbContext { get; }
        int Save();
    }

}