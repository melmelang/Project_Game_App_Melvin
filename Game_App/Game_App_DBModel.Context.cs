//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game_App
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Game_App_DbEntities : DbContext
    {
        public Game_App_DbEntities()
            : base("name=Game_App_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Sudoku> Sudoku { get; set; }
        public virtual DbSet<TicTacToe> TicTacToe { get; set; }
    }
}
