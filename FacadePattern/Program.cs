/*
 * Create facade to manage subsytems and hide subsystems implementation
 * 
 */

using FacadePattern.Facade;

ICarFacade carFacade = new CarFacade();
carFacade.Open();
carFacade.Close();

/*
 * 
Door open...
Temperature change to 21
Air conditioner start...
Temperature change to 19
Air conditioner stop...
Door close...
 * 
 */