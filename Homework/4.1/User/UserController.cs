interface IUserController<T> where T: User
{
    void Create(T user, LearningGroup group);
}