//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Padfolio_Dapper_.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PadfolioEntities1 : DbContext
    {
        public PadfolioEntities1()
            : base("name=PadfolioEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminInformation> AdminInformations { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Todolist> Todolists { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<UserNote> UserNotes { get; set; }
        public virtual DbSet<WhyPadfolio> WhyPadfolios { get; set; }
    
        public virtual int AAU(Nullable<int> adminId, string adminNameSurname, string adminPassword)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            var adminNameSurnameParameter = adminNameSurname != null ?
                new ObjectParameter("AdminNameSurname", adminNameSurname) :
                new ObjectParameter("AdminNameSurname", typeof(string));
    
            var adminPasswordParameter = adminPassword != null ?
                new ObjectParameter("AdminPassword", adminPassword) :
                new ObjectParameter("AdminPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AAU", adminIdParameter, adminNameSurnameParameter, adminPasswordParameter);
        }
    
        public virtual int ADlete(Nullable<int> adminId)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ADlete", adminIdParameter);
        }
    
        public virtual ObjectResult<AdminNoList_Result> AdminNoList(Nullable<int> adminId)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AdminNoList_Result>("AdminNoList", adminIdParameter);
        }
    
        public virtual ObjectResult<ALisT_Result> ALisT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALisT_Result>("ALisT");
        }
    
        public virtual int BAU(Nullable<int> blogId, string blogTitle, string blogPost)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            var blogTitleParameter = blogTitle != null ?
                new ObjectParameter("BlogTitle", blogTitle) :
                new ObjectParameter("BlogTitle", typeof(string));
    
            var blogPostParameter = blogPost != null ?
                new ObjectParameter("BlogPost", blogPost) :
                new ObjectParameter("BlogPost", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BAU", blogIdParameter, blogTitleParameter, blogPostParameter);
        }
    
        public virtual int BDelete(Nullable<int> blogId)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BDelete", blogIdParameter);
        }
    
        public virtual ObjectResult<BList_Result> BList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BList_Result>("BList");
        }
    
        public virtual ObjectResult<BlogNoList_Result> BlogNoList(Nullable<int> blogId)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BlogNoList_Result>("BlogNoList", blogIdParameter);
        }
    
        public virtual int PAU(Nullable<int> planId, string planTitle, string pPrice, string pExplanation)
        {
            var planIdParameter = planId.HasValue ?
                new ObjectParameter("PlanId", planId) :
                new ObjectParameter("PlanId", typeof(int));
    
            var planTitleParameter = planTitle != null ?
                new ObjectParameter("PlanTitle", planTitle) :
                new ObjectParameter("PlanTitle", typeof(string));
    
            var pPriceParameter = pPrice != null ?
                new ObjectParameter("PPrice", pPrice) :
                new ObjectParameter("PPrice", typeof(string));
    
            var pExplanationParameter = pExplanation != null ?
                new ObjectParameter("PExplanation", pExplanation) :
                new ObjectParameter("PExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PAU", planIdParameter, planTitleParameter, pPriceParameter, pExplanationParameter);
        }
    
        public virtual int PDelete(Nullable<int> planId)
        {
            var planIdParameter = planId.HasValue ?
                new ObjectParameter("PlanId", planId) :
                new ObjectParameter("PlanId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PDelete", planIdParameter);
        }
    
        public virtual ObjectResult<PlanNoList_Result> PlanNoList(Nullable<int> planId)
        {
            var planIdParameter = planId.HasValue ?
                new ObjectParameter("PlanId", planId) :
                new ObjectParameter("PlanId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PlanNoList_Result>("PlanNoList", planIdParameter);
        }
    
        public virtual ObjectResult<PList_Result> PList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PList_Result>("PList");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int TAU(Nullable<int> todolistId, string todolistTitle, string todolistExplanation)
        {
            var todolistIdParameter = todolistId.HasValue ?
                new ObjectParameter("TodolistId", todolistId) :
                new ObjectParameter("TodolistId", typeof(int));
    
            var todolistTitleParameter = todolistTitle != null ?
                new ObjectParameter("TodolistTitle", todolistTitle) :
                new ObjectParameter("TodolistTitle", typeof(string));
    
            var todolistExplanationParameter = todolistExplanation != null ?
                new ObjectParameter("TodolistExplanation", todolistExplanation) :
                new ObjectParameter("TodolistExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAU", todolistIdParameter, todolistTitleParameter, todolistExplanationParameter);
        }
    
        public virtual int TDelete(Nullable<int> todolistId)
        {
            var todolistIdParameter = todolistId.HasValue ?
                new ObjectParameter("TodolistId", todolistId) :
                new ObjectParameter("TodolistId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TDelete", todolistIdParameter);
        }
    
        public virtual ObjectResult<TList_Result> TList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TList_Result>("TList");
        }
    
        public virtual ObjectResult<TodoNoList_Result> TodoNoList(Nullable<int> todolistId)
        {
            var todolistIdParameter = todolistId.HasValue ?
                new ObjectParameter("TodolistId", todolistId) :
                new ObjectParameter("TodolistId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TodoNoList_Result>("TodoNoList", todolistIdParameter);
        }
    
        public virtual int UserInfAU(Nullable<int> userId, string userNameSurname, string userPassword)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var userNameSurnameParameter = userNameSurname != null ?
                new ObjectParameter("UserNameSurname", userNameSurname) :
                new ObjectParameter("UserNameSurname", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserInfAU", userIdParameter, userNameSurnameParameter, userPasswordParameter);
        }
    
        public virtual int UserInfDelete(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserInfDelete", userIdParameter);
        }
    
        public virtual ObjectResult<UserInfList_Result> UserInfList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserInfList_Result>("UserInfList");
        }
    
        public virtual ObjectResult<UserNoList_Result> UserNoList(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserNoList_Result>("UserNoList", userIdParameter);
        }
    
        public virtual int UserNoteAU(Nullable<int> userNoteId, string userNoteTitle, string userNoteExplanation)
        {
            var userNoteIdParameter = userNoteId.HasValue ?
                new ObjectParameter("UserNoteId", userNoteId) :
                new ObjectParameter("UserNoteId", typeof(int));
    
            var userNoteTitleParameter = userNoteTitle != null ?
                new ObjectParameter("UserNoteTitle", userNoteTitle) :
                new ObjectParameter("UserNoteTitle", typeof(string));
    
            var userNoteExplanationParameter = userNoteExplanation != null ?
                new ObjectParameter("UserNoteExplanation", userNoteExplanation) :
                new ObjectParameter("UserNoteExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserNoteAU", userNoteIdParameter, userNoteTitleParameter, userNoteExplanationParameter);
        }
    
        public virtual int UserNoteDelete(Nullable<int> userNoteId)
        {
            var userNoteIdParameter = userNoteId.HasValue ?
                new ObjectParameter("UserNoteId", userNoteId) :
                new ObjectParameter("UserNoteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserNoteDelete", userNoteIdParameter);
        }
    
        public virtual ObjectResult<UserNoteList_Result> UserNoteList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserNoteList_Result>("UserNoteList");
        }
    
        public virtual ObjectResult<UserNoteNoList_Result> UserNoteNoList(Nullable<int> userNoteId)
        {
            var userNoteIdParameter = userNoteId.HasValue ?
                new ObjectParameter("UserNoteId", userNoteId) :
                new ObjectParameter("UserNoteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserNoteNoList_Result>("UserNoteNoList", userNoteIdParameter);
        }
    
        public virtual int WAU(Nullable<int> whyId, string whyTitle, string whyExplanation)
        {
            var whyIdParameter = whyId.HasValue ?
                new ObjectParameter("WhyId", whyId) :
                new ObjectParameter("WhyId", typeof(int));
    
            var whyTitleParameter = whyTitle != null ?
                new ObjectParameter("WhyTitle", whyTitle) :
                new ObjectParameter("WhyTitle", typeof(string));
    
            var whyExplanationParameter = whyExplanation != null ?
                new ObjectParameter("WhyExplanation", whyExplanation) :
                new ObjectParameter("WhyExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("WAU", whyIdParameter, whyTitleParameter, whyExplanationParameter);
        }
    
        public virtual int WDelete(Nullable<int> whyId)
        {
            var whyIdParameter = whyId.HasValue ?
                new ObjectParameter("WhyId", whyId) :
                new ObjectParameter("WhyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("WDelete", whyIdParameter);
        }
    
        public virtual ObjectResult<WList_Result> WList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WList_Result>("WList");
        }
    
        public virtual ObjectResult<WNoList_Result> WNoList(Nullable<int> whyId)
        {
            var whyIdParameter = whyId.HasValue ?
                new ObjectParameter("WhyId", whyId) :
                new ObjectParameter("WhyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WNoList_Result>("WNoList", whyIdParameter);
        }
    
        public virtual int AdminAddUpdate(Nullable<int> adminId, string adminNameSurname, string adminPassword)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            var adminNameSurnameParameter = adminNameSurname != null ?
                new ObjectParameter("AdminNameSurname", adminNameSurname) :
                new ObjectParameter("AdminNameSurname", typeof(string));
    
            var adminPasswordParameter = adminPassword != null ?
                new ObjectParameter("AdminPassword", adminPassword) :
                new ObjectParameter("AdminPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdminAddUpdate", adminIdParameter, adminNameSurnameParameter, adminPasswordParameter);
        }
    
        public virtual int BlogAddUpdate(Nullable<int> blogId, string blogTitle, string blogPost)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            var blogTitleParameter = blogTitle != null ?
                new ObjectParameter("BlogTitle", blogTitle) :
                new ObjectParameter("BlogTitle", typeof(string));
    
            var blogPostParameter = blogPost != null ?
                new ObjectParameter("BlogPost", blogPost) :
                new ObjectParameter("BlogPost", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BlogAddUpdate", blogIdParameter, blogTitleParameter, blogPostParameter);
        }
    
        public virtual int PlanAddUpdate(Nullable<int> planId, string planTitle, string pPrice, string pExplanation)
        {
            var planIdParameter = planId.HasValue ?
                new ObjectParameter("PlanId", planId) :
                new ObjectParameter("PlanId", typeof(int));
    
            var planTitleParameter = planTitle != null ?
                new ObjectParameter("PlanTitle", planTitle) :
                new ObjectParameter("PlanTitle", typeof(string));
    
            var pPriceParameter = pPrice != null ?
                new ObjectParameter("PPrice", pPrice) :
                new ObjectParameter("PPrice", typeof(string));
    
            var pExplanationParameter = pExplanation != null ?
                new ObjectParameter("PExplanation", pExplanation) :
                new ObjectParameter("PExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PlanAddUpdate", planIdParameter, planTitleParameter, pPriceParameter, pExplanationParameter);
        }
    
        public virtual int TodolistAddUpdate(Nullable<int> todolistId, string todolistTitle, string todolistExplanation)
        {
            var todolistIdParameter = todolistId.HasValue ?
                new ObjectParameter("TodolistId", todolistId) :
                new ObjectParameter("TodolistId", typeof(int));
    
            var todolistTitleParameter = todolistTitle != null ?
                new ObjectParameter("TodolistTitle", todolistTitle) :
                new ObjectParameter("TodolistTitle", typeof(string));
    
            var todolistExplanationParameter = todolistExplanation != null ?
                new ObjectParameter("TodolistExplanation", todolistExplanation) :
                new ObjectParameter("TodolistExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TodolistAddUpdate", todolistIdParameter, todolistTitleParameter, todolistExplanationParameter);
        }
    
        public virtual int UserAddUpdate(Nullable<int> userId, string userNameSurname, string userPassword)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var userNameSurnameParameter = userNameSurname != null ?
                new ObjectParameter("UserNameSurname", userNameSurname) :
                new ObjectParameter("UserNameSurname", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserAddUpdate", userIdParameter, userNameSurnameParameter, userPasswordParameter);
        }
    
        public virtual int UserNoteAddUpdate(Nullable<int> userNoteId, string userNoteTitle, string userNoteExplanation)
        {
            var userNoteIdParameter = userNoteId.HasValue ?
                new ObjectParameter("UserNoteId", userNoteId) :
                new ObjectParameter("UserNoteId", typeof(int));
    
            var userNoteTitleParameter = userNoteTitle != null ?
                new ObjectParameter("UserNoteTitle", userNoteTitle) :
                new ObjectParameter("UserNoteTitle", typeof(string));
    
            var userNoteExplanationParameter = userNoteExplanation != null ?
                new ObjectParameter("UserNoteExplanation", userNoteExplanation) :
                new ObjectParameter("UserNoteExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserNoteAddUpdate", userNoteIdParameter, userNoteTitleParameter, userNoteExplanationParameter);
        }
    
        public virtual int WhyAddUpdate(Nullable<int> whyId, string whyTitle, string whyExplanation)
        {
            var whyIdParameter = whyId.HasValue ?
                new ObjectParameter("WhyId", whyId) :
                new ObjectParameter("WhyId", typeof(int));
    
            var whyTitleParameter = whyTitle != null ?
                new ObjectParameter("WhyTitle", whyTitle) :
                new ObjectParameter("WhyTitle", typeof(string));
    
            var whyExplanationParameter = whyExplanation != null ?
                new ObjectParameter("WhyExplanation", whyExplanation) :
                new ObjectParameter("WhyExplanation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("WhyAddUpdate", whyIdParameter, whyTitleParameter, whyExplanationParameter);
        }
    }
}
