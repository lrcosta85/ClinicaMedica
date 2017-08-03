﻿CREATE TABLE [dbo].[Agendas] (
    [ID] [uniqueidentifier] NOT NULL,
    [PacienteID] [uniqueidentifier] NOT NULL,
    [Data] [datetime] NOT NULL,
    [Horario] [varchar](6) NOT NULL,
    [Medico] [varchar](50) NOT NULL,
    [Tipo] [varchar](20) NOT NULL,
    [Detalhes] [varchar](200),
    [Confirmada] [bit] NOT NULL,
    CONSTRAINT [PK_dbo.Agendas] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Pacientes] (
    [ID] [uniqueidentifier] NOT NULL,
    [Nome] [varchar](150) NOT NULL,
    [DataNascimento] [datetime],
    [CPF] [varchar](11) NOT NULL,
    [Endereco] [varchar](100),
    [EnderecoNumero] [varchar](5),
    [Bairro] [varchar](30) NOT NULL,
    [CEP] [varchar](10) NOT NULL,
    [EnderecoComplemento] [varchar](20),
    [Cidade] [varchar](30) NOT NULL,
    [Estado] [varchar](2),
    [TelefoneDDD] [varchar](2) NOT NULL,
    [Telefone] [varchar](12) NOT NULL,
    [CelularDDD] [varchar](2) NOT NULL,
    [Celular] [varchar](12) NOT NULL,
    [Email] [varchar](100),
    [Convenio] [varchar](30),
    [DataCadastro] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Pacientes] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_PacienteID] ON [dbo].[Agendas]([PacienteID])
CREATE UNIQUE INDEX [IX_CPF] ON [dbo].[Pacientes]([CPF])
ALTER TABLE [dbo].[Agendas] ADD CONSTRAINT [FK_dbo.Agendas_dbo.Pacientes_PacienteID] FOREIGN KEY ([PacienteID]) REFERENCES [dbo].[Pacientes] ([ID])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201707280034503_AutomaticMigration', N'LR.ClinicaMedica.Infra.Data.Migrations.Configuration',  0x1F8B0800000000000400E55ADB6EDC36107D2FD07F10F458382BAF8D16A9B19BC0D9B55323F105DE75D0B7809666D744294A1129C38BA25FD6877E527FA1C3D58DA22E2BED256D5004086C8A3C331CCE0C8773FCF79F7F8DDEBEF8CC7A8648D0808FEDE1E0D8B680BB8147F9726CC772F1EAB5FDF6CDF7DF8D2E3CFFC5FA94CD3B55F370251763FB49CAF0CC7184FB043E11039FBA512082851CB881EF102F704E8E8F7F7686430710C2462CCB1ADDC75C521FD6BFE0AF9380BB10CA98B0EBC00326D271FC325BA35A37C407111217C6F6C7FBC184514E5D720D1EFE3FB8E28B880CA6449201E2487891B675CE2841D566C016B645380F2491A8F8D98380998C02BE9C853840D87C1502CE5B102620DDD05931BDEBDE8E4FD4DE9C626106E5C642067E4FC0E1696A2CC75CBE95C9EDDC9868CE0B34BB5CA95DAF4D3AB6CF97C03D625BA6A8B3098BD4B41A7B4F711EE583E4A40609C091D530ED28F719742DF5EFC89AC44CC6118C39C43222ECC8BA8B1F19753FC06A1EFC067CCC63C674A5516DFC561AC0A1BB28082192AB7B58A45BB99ADA96535EE7980BF365DA9A649BEF63EAD9D60DCA268F0C7297705A97DF119702BADC8E30CA773300FC19E6181ABD417E092212D120C34137C710B6AD6BF2F211F8523E8DED9F6CEB92BE8097FD9EC23EE0A1E1598E6D19C5FDC5AE4FBB4DEA8FC787103BA7619BD09383089D8224EC0944ABE06E92DB05611E5BD0C8275EEE16EF828001E19B55BE21CF74B90EE1065FB5AD7B60EB09E28986498E4CA3F87331E7320AFCFB80E51922FFF47916C4918B33E641FDF739899620CB7A8D9C22F1B4A6A34281AD135206F13F4D493781CA1D8DFE393C4C38AA0C7643848B898BCBA09ACB36B8FBDD659BCA4343E344C3DD14BEE01E44D09AB8867B09E54CD04DEC43D49A27F720EC1DA151AB90D3839CFEE4E2AED58E879099D97512F8218392DB6D7F1F6CD826F588D7165C87B1EE859058D2B56D6E0F7B9B038345C0613A9DEE2CA9EF559E8A6E73A183089E008B1989FE852DA792BFFA8E2FF0FE63074F7958BD3C036F2D453B46CAE64B678235929051CD95B375A194143462D73A29AB839AEAA4AC8EEA52279D0B11B874AD4C49C94291F2DE30395A1BAAB7E4648A3DE1F1601144432C7B5081B1FD43C560CDA0F9560BD0C24265D8610516AB254CE45CBDC6D171F02CB14493D5D28A72978684B56B602CEB589329BBE702CC2F530851140A69376817C9FA6BB1AA412EC8A81737D967E468DE512DAE554B0457409405A75E11E7FD924AB5FD20202DB8451A8CA63328F0194833680A0736DCABE24D6580CC38751085331920DACE4D55B418D5663584B179189BE327575FDB7AE54C37478C06A319C07C3294B759932FF2432E1A674ED239CB3A6C4E438B6D744DC210B3B3D6724B47AC59D26F9BBC9AF5EF3BF90986E38A9AF653AE6D2E4906115982F1555D241E5CD2484895E91F894AE213CFAF4EAB73E9066FCB4496BDB67A70990766F3D5CFC99A0EFDC7CCE7AB492185BBC4EDAA9275BD73A8F85275E1BA134AB064A8792C4E0216FBBC39B935AFD613928ED296A89AD1922E968E938C7447C85B583A483ED81D27EB49E930D9587794A4C5A46324233D2C92F78B4A56C947BB23E90D211D4B1FAFA28D1CC3DF2A974EC5D18DCC63C64DA7A82A32D9BEE3AA29617788ACE6A58789ADA40FA3AF4F46FAC593DE5331234BFFD6C39354AFA5E4426AA0FBFAA271A28314A3FD91B2CE481D5EF6AD3B6AD602D1D1B2B11E56521D8D9295D440FFBD95BA13751B2C4DE8A15FDA8A28A9988EF5D032ED2C94144BC77AE449BD75504A97FA87FE78F560BDACA43DF04B96D2C67BA3D542F5B27AF2082F193D19EA751FA44F6CE3364847FB6599E2116DE698E2CB57BE5D2A95AD3925979E57B846253B4AABCACD8C72A5CC4CA6D8169AEA997AAAC49CAD84043FB98C665F185E54B8DF62C235E1740142266C8122815E1B1CF47F870F7684F0582752F8AB131E31A75F62A0EA114C1714A23DF0B155C8CA53F70A53F1CBD8FE7D8D71665DFDFAB98039B26E233CDF33EBD8FA63275AD72312E41E68DD6712B94F2ADF9479DD9D48DB3A4C4513ED40C9D6419EF4873409D77AD812EE76F4EA23951B94EB4F617E7BE1A3738775A61E6EE115F5CC605D38743AB98229CC15EC10D0B8ECC8BA120F6B039D597394A4E2D9201977A4106B2DD6DF39EB09C3DA18ED0B5DA607EB204FFB1FB046FED55B609FD4DEE6BCD29FC8DB931DCA345DADA27DF5AC21E536E26E45B9D51E5C7FD82AA1B61F750DBA6C4FDA96C8B03D05AF497D6DF6AD6D89AE8E05C5FE19A5A2AFBE15DD63F6C4B7A2A2B6E28C5A9A47076289BE2156A8D269EF42F7B4B03DC9130ADDF451796CE29E0D44492315D4CA04D50968A6500E4F14994A979B8E9BB9A11A4AE9304450F5598CDEA4FD3936FAB2A0CB0242FD713607B7E447F99C2BBE0832973634CAA6549E1E784DA2939D4758A41257E267178458FF81C027C2E275627E04EF8ADFC6328C256E19FC47B6D28DA1C2A24DFE9AED2AEB3CBA0DD754FE3EB6806A52957E6FF9BB98322FD7FBB226FD3640A8787B0F389E9C2586AF84E52A47BAA934BA9A8052F3E569620E58332198B8E533F20CDBE8F620E0232C89BBCABA1BCD209B0FA26CF6D1949265447C916214EBF157F461CF7F79F30F6CB5C02C95300000 , N'6.1.3-40302')
