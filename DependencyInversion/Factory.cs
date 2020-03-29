public static class Factory {
    public static IPerson CreatePerson(){
        return new Owner();
    }

    public static IProduct CreateProduct(){
        return new Phone(
            10,
            CreateMessager(),
            CreateLogger());
    }

    public static ILogger CreateLogger(){
        return new Logger();
    }

    public static IMessageSender CreateMessager(){
        return new Emailer();
    }
}