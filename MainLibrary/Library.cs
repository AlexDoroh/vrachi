using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace MainLibrary
{
    public class Library
    {
        #region Sotrudniks

        public IEnumerable<Sotrudnik> GetSotrudnikByName(string name)
        {
            try
            {
                string sql = "SELECT * FROM sotrudniki WHERE FullName = @FullName";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Sotrudnik>(sql, new Sotrudnik { FullName = name });
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public IEnumerable<Sotrudnik> GetAllSotrudniks()
        {
            try
            {
                string sql = "SELECT * FROM sotrudniki";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Sotrudnik>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public IEnumerable<Sotrudnik> GetSotrudnikById(int id)
        {
            try
            {
                string sql = "SELECT * FROM sotrudniki WHERE Id = @Id";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Sotrudnik>(sql, new Sotrudnik {Id = id });
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void AddSotrudnik(Sotrudnik sotrudnik)
        {
            try
            {
                string sql = @"INSERT INTO sotrudniki (FullName,Specialization,CabNumber,WorkStart,WorkEnd)
                                                VALUES (@FullName,@Specialization,@CabNumber,@WorkStart,@WorkEnd)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, sotrudnik);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteSotrudnik(int id)
        {
            try
            {
                string sql = "DELETE FROM sotrudniki WHERE Id = @Id";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute(sql,new Sotrudnik {Id = id });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateSotrudnik(Sotrudnik sotrudnik)
        {
            try
            {
                string sql = @"UPDATE sotrudniki SET FullName = @FullName,Specialization = @Specialization,CabNumber = @CabNumber,WorkStart=@WorkStart,WorkEnd=@WorkEnd WHERE Id = @Id ";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, sotrudnik);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Pacients

        public IEnumerable<Pacient> GetPacientByName(string name)
        {
            try
            {
                string sql = "SELECT * FROM pacients WHERE FullName = @FullName";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Pacient>(sql,new Pacient {FullName = name });
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public IEnumerable<Pacient> GetAllPacients()
        {
            try
            {
                string sql = "SELECT * FROM pacients";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Pacient>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public IEnumerable<Pacient> GetPacientById(int id)
        {
            try
            {
                string sql = "SELECT * FROM pacients WHERE Id = @Id";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Pacient>(sql, new Pacient { Id = id });
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void AddPacient(Pacient pacient)
        {
            try
            {
                string sql = @"INSERT INTO pacients (FullName,Address)
                                                VALUES (@FullName,@Address)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, pacient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeletePacient(int id)
        {
            try
            {
                string sql = "DELETE FROM pacients WHERE Id = @Id";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    con.Execute(sql, new Pacient { Id = id });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdatePacient(Pacient pacient)
        {
            try
            {
                string sql = @"UPDATE pacients SET FullName = @FullName,Address = @Address WHERE Id = @Id ";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, pacient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Notes

        public IEnumerable<Note> GetAllNotes()
        {
            try
            {
                string sql = "SELECT * FROM notes";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Query<Note>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void AddNote(Note note)
        {
            try
            {
                string sql = @"INSERT INTO notes (PacientId,SotrudnikId,NoteTime)
                                                VALUES (@PacientId,@SotrudnikId,@NoteTime)";
                using (IDbConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    con.Open();
                    var result = con.Execute(sql, note);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}