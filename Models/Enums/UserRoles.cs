namespace MoneyPortal.Models.Enums
{
    public enum UserRoles
    {
        /*
         * Roles Permissions
         * Owner - Has full access to invite members & create budgets and can delete the household
         * Member - Has ablility inside an invited household to personal bank accounts to household
         * Personal - 
         */
        Owner,
        Member,
        Personal
    }
}
