﻿using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private UserRepository? _userRepository;
    private UserTokenRepository? _userTokenRepository;
    private AppointmentRepository? _appointmentRepository;
    private PolyclinicRepository? _polyclinicRepository;
    private PolyclinicDoctorRepository? _polyclinicDoctorRepository;


    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);
    public IAppointmentRepository Appointments => _appointmentRepository ??= new AppointmentRepository(_postgresContext);
    public IPolyclinicRepository Polyclinics => _polyclinicRepository ??= new PolyclinicRepository(_postgresContext);
    public IPolyclinicDoctorRepository PolyclinicDoctors => _polyclinicDoctorRepository ??= new PolyclinicDoctorRepository(_postgresContext);

    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}