using System;

using System.Data.SqlClient;

namespace StokTakip
{
    public class ProjectAdapters
    {
        public static SqlDataAdapter adpCariHesaplar(SqlConnection con, SqlTransaction trans, bool selectOnly)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblCariHesaplar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CariID", "CariID"),
                        new System.Data.Common.DataColumnMapping("Unvan", "Unvan"),
                        new System.Data.Common.DataColumnMapping("VergiNo", "VergiNo"),
                        new System.Data.Common.DataColumnMapping("VergiDairesi", "VergiDairesi"),
                        new System.Data.Common.DataColumnMapping("Adres", "Adres"),
                        new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
                        new System.Data.Common.DataColumnMapping("Mail", "Mail")})});

            // 
            // sqlSelectCommand1
            // 
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;

            adp.SelectCommand.CommandText = "SELECT * FROM tblCariHesaplar";


            if (selectOnly)
                return adp;

            // 
            // sqlInsertCommand1
            // 
            adp.InsertCommand = new SqlCommand();

            adp.InsertCommand.CommandText = @"INSERT INTO [tblCariHesaplar] ([Unvan], [VergiNo], [VergiDairesi], [Adres], [Telefon], [Mail]) VALUES (@Unvan, @VergiNo, @VergiDairesi, @Adres, @Telefon, @Mail);
SELECT CariID, Unvan, VergiNo, VergiDairesi, Adres, Telefon, Mail FROM tblCariHesaplar WHERE (CariID = SCOPE_IDENTITY())";


            adp.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.NVarChar, 0, "Unvan"),
            new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.NVarChar, 0, "VergiNo"),
            new System.Data.SqlClient.SqlParameter("@VergiDairesi", System.Data.SqlDbType.NVarChar, 0, "VergiDairesi"),
            new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.NVarChar, 0, "Adres"),
            new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar, 0, "Telefon"),
            new System.Data.SqlClient.SqlParameter("@Mail", System.Data.SqlDbType.NVarChar, 0, "Mail")});
            // 
            // 
            // sqlUpdateCommand1
            // 

            adp.UpdateCommand = new SqlCommand();

            adp.UpdateCommand.CommandText = @"UPDATE [tblCariHesaplar] SET [Unvan] = @Unvan, [VergiNo] = @VergiNo, [VergiDairesi] = @VergiDairesi, [Adres] = @Adres, [Telefon] = @Telefon, [Mail] = @Mail WHERE (([CariID] = @Original_CariID));
SELECT CariID, Unvan, VergiNo, VergiDairesi, Adres, Telefon, Mail FROM tblCariHesaplar WHERE (CariID = @CariID)";



            adp.UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.NVarChar, 0, "Unvan"),
            new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.NVarChar, 0, "VergiNo"),
            new System.Data.SqlClient.SqlParameter("@VergiDairesi", System.Data.SqlDbType.NVarChar, 0, "VergiDairesi"),
            new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.NVarChar, 0, "Adres"),
            new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar, 0, "Telefon"),
            new System.Data.SqlClient.SqlParameter("@Mail", System.Data.SqlDbType.NVarChar, 0, "Mail"),
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 4, "CariID")});
            // 
            // sqlDeleteCommand1
            // 

            adp.DeleteCommand = new SqlCommand();

            adp.DeleteCommand.CommandText = "DELETE FROM [tblCariHesaplar] WHERE (([CariID] = @Original_CariID))";

            adp.DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpStokInsert
            // 


            adp.InsertCommand.Connection = con;
            adp.UpdateCommand.Connection = con;
            adp.DeleteCommand.Connection = con;


            if (trans != null)
            {
                adp.InsertCommand.Transaction = trans;
                adp.UpdateCommand.Transaction = trans;
                adp.DeleteCommand.Transaction = trans;
            }

            return adp;

        }

        public static SqlDataAdapter adpBirim(SqlConnection con, SqlTransaction trans, bool selectOnly)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblBirim", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("BirimAdi", "BirimAdi")})});

            // 
            // sqlSelectCommand1
            // 
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;

            adp.SelectCommand.CommandText = "SELECT * FROM tblBirim";


            if (selectOnly)
                return adp;

            // 
            // sqlInsertCommand1
            // 
            adp.InsertCommand = new SqlCommand();

            adp.InsertCommand.CommandText = @"INSERT INTO [tblBirim] ([BirimAdi]) VALUES (@BirimAdi);
SELECT BirimID, BirimAdi FROM tblBirim WHERE (BirimID = SCOPE_IDENTITY())";


            adp.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimAdi", System.Data.SqlDbType.NVarChar, 0, "BirimAdi")});
            // 
            // 
            // sqlUpdateCommand1
            // 

            adp.UpdateCommand = new SqlCommand();

            adp.UpdateCommand.CommandText = @"UPDATE [tblBirim] SET [BirimAdi] = @BirimAdi WHERE (([BirimID] = @Original_BirimID));
SELECT BirimID, BirimAdi FROM tblBirim WHERE (BirimID = @BirimID)";



            adp.UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimAdi", System.Data.SqlDbType.NVarChar, 0, "BirimAdi"),
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 4, "BirimID")});
            // 
            // sqlDeleteCommand1
            // 

            adp.DeleteCommand = new SqlCommand();

            adp.DeleteCommand.CommandText = "DELETE FROM [tblBirim] WHERE (([BirimID] = @Original_BirimID))";

            adp.DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpStokInsert
            // 


            adp.InsertCommand.Connection = con;
            adp.UpdateCommand.Connection = con;
            adp.DeleteCommand.Connection = con;


            if (trans != null)
            {
                adp.InsertCommand.Transaction = trans;
                adp.UpdateCommand.Transaction = trans;
                adp.DeleteCommand.Transaction = trans;
            }

            return adp;

        }

        public static SqlDataAdapter adpStok(SqlConnection con, SqlTransaction trans, bool selectOnly)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblStok", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StokID", "StokID"),
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("Barkod", "Barkod"),
                        new System.Data.Common.DataColumnMapping("StokAdi", "StokAdi"),
                        new System.Data.Common.DataColumnMapping("StokKod", "StokKod"),
                        new System.Data.Common.DataColumnMapping("StokFiyat", "StokFiyat"),
                        new System.Data.Common.DataColumnMapping("StokKdvOrani", "StokKdvOrani")})});

            // 
            // sqlSelectCommand1
            // 
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;

            adp.SelectCommand.CommandText = "SELECT * FROM tblStok";


            if (selectOnly)
                return adp;

            // 
            // sqlInsertCommand1
            // 
            adp.InsertCommand = new SqlCommand();

            adp.InsertCommand.CommandText = @"INSERT INTO [tblStok] ([BirimID], [Barkod], [StokAdi], [StokKod], [StokFiyat], [StokKdvOrani]) VALUES (@BirimID, @Barkod, @StokAdi, @StokKod, @StokFiyat, @StokKdvOrani);
SELECT StokID, BirimID, Barkod, StokAdi, StokKod, StokFiyat, StokKdvOrani FROM tblStok WHERE (StokID = SCOPE_IDENTITY())";


            adp.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@StokAdi", System.Data.SqlDbType.NVarChar, 0, "StokAdi"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "StokFiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Current, null)});
            // 
            // 
            // sqlUpdateCommand1
            // 

            adp.UpdateCommand = new SqlCommand();

            adp.UpdateCommand.CommandText = @"UPDATE [tblStok] SET [BirimID] = @BirimID, [Barkod] = @Barkod, [StokAdi] = @StokAdi, [StokKod] = @StokKod, [StokFiyat] = @StokFiyat, [StokKdvOrani] = @StokKdvOrani WHERE (([StokID] = @Original_StokID) AND ((@IsNull_BirimID = 1 AND [BirimID] IS NULL) OR ([BirimID] = @Original_BirimID)) AND ((@IsNull_Barkod = 1 AND [Barkod] IS NULL) OR ([Barkod] = @Original_Barkod)) AND ((@IsNull_StokAdi = 1 AND [StokAdi] IS NULL) OR ([StokAdi] = @Original_StokAdi)) AND ((@IsNull_StokKod = 1 AND [StokKod] IS NULL) OR ([StokKod] = @Original_StokKod)) AND ((@IsNull_StokFiyat = 1 AND [StokFiyat] IS NULL) OR ([StokFiyat] = @Original_StokFiyat)) AND ((@IsNull_StokKdvOrani = 1 AND [StokKdvOrani] IS NULL) OR ([StokKdvOrani] = @Original_StokKdvOrani)));
SELECT StokID, BirimID, Barkod, StokAdi, StokKod, StokFiyat, StokKdvOrani FROM tblStok WHERE (StokID = @StokID)";



            adp.UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@StokAdi", System.Data.SqlDbType.NVarChar, 0, "StokAdi"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "StokFiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_StokID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Barkod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Barkod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Barkod", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Barkod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokAdi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokAdi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokAdi", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokAdi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokKod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokKod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokKod", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokKod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokFiyat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokFiyat", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "StokFiyat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokKdvOrani", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@StokID", System.Data.SqlDbType.Int, 4, "StokID")});
            // 
            // sqlDeleteCommand1
            // 

            adp.DeleteCommand = new SqlCommand();

            adp.DeleteCommand.CommandText = "DELETE FROM [tblStok] WHERE (([StokID] = @Original_StokID) AND ((@IsNull_BirimID = 1 AND [BirimID] IS NULL) OR ([BirimID] = @Original_BirimID)) AND ((@IsNull_Barkod = 1 AND [Barkod] IS NULL) OR ([Barkod] = @Original_Barkod)) AND ((@IsNull_StokAdi = 1 AND [StokAdi] IS NULL) OR ([StokAdi] = @Original_StokAdi)) AND ((@IsNull_StokKod = 1 AND [StokKod] IS NULL) OR ([StokKod] = @Original_StokKod)) AND ((@IsNull_StokFiyat = 1 AND [StokFiyat] IS NULL) OR ([StokFiyat] = @Original_StokFiyat)) AND ((@IsNull_StokKdvOrani = 1 AND [StokKdvOrani] IS NULL) OR ([StokKdvOrani] = @Original_StokKdvOrani)))";

            adp.DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_StokID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Barkod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Barkod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Barkod", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Barkod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokAdi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokAdi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokAdi", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokAdi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokKod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokKod", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokKod", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StokKod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokFiyat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokFiyat", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "StokFiyat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StokKdvOrani", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Original, null)});
            // 
            // adpStokInsert
            // 


            adp.InsertCommand.Connection = con;
            adp.UpdateCommand.Connection = con;
            adp.DeleteCommand.Connection = con;


            if (trans != null)
            {
                adp.InsertCommand.Transaction = trans;
                adp.UpdateCommand.Transaction = trans;
                adp.DeleteCommand.Transaction = trans;
            }

            return adp;

        }

        public static SqlDataAdapter adpStokHareket(SqlConnection con, SqlTransaction trans, bool selectOnly)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblStokHareket", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("HareketID", "HareketID"),
                        new System.Data.Common.DataColumnMapping("FaturaID", "FaturaID"),
                        new System.Data.Common.DataColumnMapping("StokID", "StokID"),
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("StokKod", "StokKod"),
                        new System.Data.Common.DataColumnMapping("Barkod", "Barkod"),
                        new System.Data.Common.DataColumnMapping("Fiyat", "Fiyat"),
                        new System.Data.Common.DataColumnMapping("Tutar", "Tutar"),
                        new System.Data.Common.DataColumnMapping("KdvOrani", "KdvOrani"),
                        new System.Data.Common.DataColumnMapping("Miktar", "Miktar"),
                        new System.Data.Common.DataColumnMapping("KdvTutari", "KdvTutari")})});

            // 
            // sqlSelectCommand1
            // 
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;

            adp.SelectCommand.CommandText = "SELECT * FROM tblStok";


            if (selectOnly)
                return adp;

            // 
            // sqlInsertCommand1
            // 
            adp.InsertCommand = new SqlCommand();

            adp.InsertCommand.CommandText = @"INSERT INTO [tblStokHareket] ([FaturaID], [StokID], [BirimID], [StokKod], [Barkod], [Fiyat], [Tutar], [KdvOrani], [Miktar], [KdvTutari]) VALUES (@FaturaID, @StokID, @BirimID, @StokKod, @Barkod, @Fiyat, @Tutar, @KdvOrani, @Miktar, @KdvTutari);
SELECT HareketID, FaturaID, StokID, BirimID, StokKod, Barkod, Fiyat, Tutar, KdvOrani, Miktar, KdvTutari FROM tblStokHareket WHERE (HareketID = SCOPE_IDENTITY())";


            adp.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 0, "FaturaID"),
            new System.Data.SqlClient.SqlParameter("@StokID", System.Data.SqlDbType.Int, 0, "StokID"),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@Fiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Fiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tutar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Tutar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Miktar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Miktar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvTutari", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "KdvTutari", System.Data.DataRowVersion.Current, null)});            // 
            // 
            // sqlUpdateCommand1
            // 

            adp.UpdateCommand = new SqlCommand();

            adp.UpdateCommand.CommandText = @"UPDATE [tblStokHareket] SET [FaturaID] = @FaturaID, [StokID] = @StokID, [BirimID] = @BirimID, [StokKod] = @StokKod, [Barkod] = @Barkod, [Fiyat] = @Fiyat, [Tutar] = @Tutar, [KdvOrani] = @KdvOrani, [Miktar] = @Miktar, [KdvTutari] = @KdvTutari WHERE (([HareketID] = @Original_HareketID));
SELECT HareketID, FaturaID, StokID, BirimID, StokKod, Barkod, Fiyat, Tutar, KdvOrani, Miktar, KdvTutari FROM tblStokHareket WHERE (HareketID = @HareketID)";



            adp.UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 0, "FaturaID"),
            new System.Data.SqlClient.SqlParameter("@StokID", System.Data.SqlDbType.Int, 0, "StokID"),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@Fiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Fiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tutar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Tutar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Miktar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Miktar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvTutari", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "KdvTutari", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@HareketID", System.Data.SqlDbType.Int, 4, "HareketID")});            // 
            // sqlDeleteCommand1
            // 

            adp.DeleteCommand = new SqlCommand();

            adp.DeleteCommand.CommandText = "DELETE FROM [tblStokHareket] WHERE (([HareketID] = @Original_HareketID))";

            adp.DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null)});
            //
            // adpStokInsert
            // 


            adp.InsertCommand.Connection = con;
            adp.UpdateCommand.Connection = con;
            adp.DeleteCommand.Connection = con;


            if (trans != null)
            {
                adp.InsertCommand.Transaction = trans;
                adp.UpdateCommand.Transaction = trans;
                adp.DeleteCommand.Transaction = trans;
            }

            return adp;

        }

        public static SqlDataAdapter adpFatura(SqlConnection con, SqlTransaction trans, bool selectOnly)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblFatura", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FaturaID", "FaturaID"),
                        new System.Data.Common.DataColumnMapping("CariID", "CariID"),
                        new System.Data.Common.DataColumnMapping("FaturaTarihi", "FaturaTarihi"),
                        new System.Data.Common.DataColumnMapping("FaturaNo", "FaturaNo"),
                        new System.Data.Common.DataColumnMapping("AraToplam", "AraToplam"),
                        new System.Data.Common.DataColumnMapping("GenelToplam", "GenelToplam"),
                        new System.Data.Common.DataColumnMapping("KdvToplam", "KdvToplam")})});

            // 
            // sqlSelectCommand1
            // 
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;

            adp.SelectCommand.CommandText = "SELECT * FROM tblStok";


            if (selectOnly)
                return adp;

            // 
            // sqlInsertCommand1
            // 
            adp.InsertCommand = new SqlCommand();

            adp.InsertCommand.CommandText = @"INSERT INTO [tblFatura] ([CariID], [FaturaTarihi], [FaturaNo], [AraToplam], [GenelToplam], [KdvToplam]) VALUES (@CariID, @FaturaTarihi, @FaturaNo, @AraToplam, @GenelToplam, @KdvToplam);
SELECT FaturaID, CariID, FaturaTarihi, FaturaNo, AraToplam, GenelToplam, KdvToplam FROM tblFatura WHERE (FaturaID = SCOPE_IDENTITY())";


            adp.InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.VarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "KdvToplam", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 

            adp.UpdateCommand = new SqlCommand();

            adp.UpdateCommand.CommandText = @"UPDATE [tblFatura] SET [CariID] = @CariID, [FaturaTarihi] = @FaturaTarihi, [FaturaNo] = @FaturaNo, [AraToplam] = @AraToplam, [GenelToplam] = @GenelToplam, [KdvToplam] = @KdvToplam WHERE (([FaturaID] = @Original_FaturaID));
SELECT FaturaID, CariID, FaturaTarihi, FaturaNo, AraToplam, GenelToplam, KdvToplam FROM tblFatura WHERE (FaturaID = @FaturaID)";



            adp.UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.VarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "KdvToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 4, "FaturaID")});
            //
            // sqlDeleteCommand1
            // 

            adp.DeleteCommand = new SqlCommand();

            adp.DeleteCommand.CommandText = "DELETE FROM [tblFatura] WHERE (([FaturaID] = @Original_FaturaID))";

            adp.DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null)});
            //
            // adpStokInsert
            // 


            adp.InsertCommand.Connection = con;
            adp.UpdateCommand.Connection = con;
            adp.DeleteCommand.Connection = con;


            if (trans != null)
            {
                adp.InsertCommand.Transaction = trans;
                adp.UpdateCommand.Transaction = trans;
                adp.DeleteCommand.Transaction = trans;
            }

            return adp;

        }
    }

}