﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_banco
{
    class Aluno
    {
        private string cpf;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private bool Ativo;
        private byte[] foto;
        private byte[] foto1;


        public Aluno(string cpf, string nome, string rua, String numero, String bairro, string complemento, string cep, string cidade,
       string estado, string telefone, string email, byte[]foto)
        {

            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNuemro(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setAtivo(Ativo);
            setFoto(foto);

        }

        public Aluno(string cpf1, string cpf)
        {
            setCPF(cpf1);
        }


        public Aluno( string nome, string rua, String numero, String bairro, string complemento, string cep, string cidade,
      string estado, string telefone, string email)
        {
            setNome(nome);
            setRua(rua);
            setNuemro(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setAtivo(Ativo);

        }

        public Aluno ()
        {

        }


        public Aluno(string cpf)
        {
            this.cpf = cpf;
        }



        public bool verificaCPF(string CPF) //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(",", "");
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }



        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                Console.WriteLine("insert into Estudo_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno," +
                    "bairroAluno, complementoAluno, CEPAluno, cidadeAluno, telefoneAluno, emailAluno, fotoAluno) values " +
                    "('" + cpf + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + cep + "','" +
                    cidade + "','" + estado + "','" + telefone + "','" + email + "',@foto)");

                MySqlCommand insere = new MySqlCommand("insert into Estudo_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno," +
                    "bairroAluno, complementoAluno, CEPAluno, cidadeAluno, telefoneAluno, emailAluno, fotoAluno) values " +
                    "('" + cpf + "','" + nome + "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + cep + "','" +
                    cidade + "','" + estado + "','" + telefone + "','" + email + "',@foto)", DAO_Conexao.con);
                insere.Parameters.AddWithValue("foto", this.foto);

                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool consultarAluno()
        {

            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Aluno" +
                    "WHERE CPFAluno= '" + cpf + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;

        }

        public MySqlDataReader ConsultarNome()
        {

            MySqlDataReader resul = null;

            try
            {
                Console.WriteLine(cpf);
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudo_Aluno  where CPFAluno= '" + cpf + "'", DAO_Conexao.con);
                //MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma INNER JOIN Estudo_Aluno on Estudio_Turma.NomeTurma = Estudo_Aluno.nomeAluno WHERE Estudo_Aluno.CPFAluno= '" + cpf + "'", DAO_Conexao.con);
                    resul = consulta.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            return resul;

        }

        public MySqlDataReader consultarAluno1()
        {
          
            MySqlDataReader resul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudo_Aluno" +
                    "WHERE CPFAluno= '" + cpf + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    resul = consulta.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          /*  finally
            {
                DAO_Conexao.con.Close();
            }*/
            return resul;

        }


        public bool atualizarAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand atualiza = new MySqlCommand("update Estudo_Aluno set nomeAluno = '" 
                    + nome + "',ruaAluno ='" + rua + "', numeroAluno ='" + numero + "',bairroAluno= '" + bairro + "',complementoAluno='" + complemento + "',CEPAluno='" + cep + "',cidadeAluno='" +
                    cidade + "',estadoAluno='" + estado + "',telefoneAluno='" + telefone + "',emailaluno='" + email + "',@foto)", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;

        }


        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudo_Aluno set ativo" +
                "= 1 where cpfAluno = '" + cpf + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }


        public Aluno(string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, byte[] foto1) : this(nome, rua, numero, bairro, complemento, cep, cidade, estado, telefone, email)
        {
            this.foto1 = foto1;
        }

        private void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        private string getCPF()
        {
            return this.cpf;
        }

        private void setNome(string nome)
        {
            this.nome = nome;
        }

        private string getNome()
        {
            return this.nome;
        }

        private void setRua(string rua)
        {
            this.rua = rua;
        }

        private string getRua()
        {
            return this.rua;
        }

        private void setNuemro(string numero)
        {
            this.numero = numero;
        }

        private string getNumero()
        {
            return this.numero;
        }

        private void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        private string getBairro()
        {
            return this.bairro;
        }

        private void setComplemento(string complementp)
        {
           complemento = this.complemento;
        }

        private string getComplemento()
        {
            return this.complemento;
        }

        private void setCep(string cep)
        {
            this.cep = cep;
        }

        private string getCep()
        {
            return this.cep;
        }

        private void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        private string getCidade()
        {
            return this.cidade;
        }

        private void setEstado(string estado)
        {
            this.estado = estado;
        }

        private string getEstado()
        {
            return this.estado;
        }

        private void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        private string getTelefone()
        {
            return this.telefone;
        }

        private void setEmail(string email)
        {
            this.email = email;
        }

        private string getEmail()
        {
            return this.email;
        }

        private void setFoto(byte[] foto)
        {
            this.foto = foto;
        }

       private byte[] getFoto()
        {
            return this.foto;
        }

        private void setAtivo(bool Ativo)
        {
            this.Ativo = Ativo;
        }

        private bool getAtivo()
        {
            return this.Ativo;
        }
    }
}
