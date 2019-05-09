using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TesteTracking.Domain.Entities;

namespace TesteTracking
{
    public class ProdutoGrupoMapping : IEntityTypeConfiguration<ProdutoGrupo>
    {
        public void Configure(EntityTypeBuilder<ProdutoGrupo> builder)
        {
            builder.ToTable("ProdutoGrupo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.NomeGrupo).IsRequired().HasMaxLength(150);

        }
    }
}
