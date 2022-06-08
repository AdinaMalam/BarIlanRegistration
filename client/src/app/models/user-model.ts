export class UserModel {
    constructor(
        public firstName: string,
        public lastName: string,
        public role: string,
        public email: string,
        public phone: string, 
        public phoneAtSchool: string,
        public password: string,
        public confirmPassword: string,
        public IUserId :number,
        public ICreatedByUserId :number,
        public DtCreateDate :Date,
        public ILastModifyUserId :number,
        public DtLastModifyDate :Date,
        public ISysRowStatus :number,
        public NvUserName : string,
        public IInstitutionId :number,
        public IInstitutionUserRoleId :number
        ) {}
}

