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
    using System.Collections.Generic;
    
    public partial class Sudoku
    {
        public int SudokuId { get; set; }
        public int Score { get; set; }
        public int Difficulty { get; set; }
        public int PlayerId { get; set; }
    
        public virtual Player Player { get; set; }
    }
}
