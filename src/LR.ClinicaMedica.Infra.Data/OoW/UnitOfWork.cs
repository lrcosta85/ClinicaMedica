using LR.ClinicaMedica.Infra.Data.Context;
using LR.ClinicaMedica.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR.ClinicaMedica.Infra.Data.OoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicaMedicaContext _context;

        private bool _disposed;

        public UnitOfWork(ClinicaMedicaContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
