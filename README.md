# Relaybox
Relay Control GUI for remote bench

Original
	- To automate some complex / repetitive tests which requires switching multiple input and measuring multiple outputs on DUT
	- Design of the interface was meant to be small and able to be dismantled & setup easily.
	- Design was meant to be controlled by means of remote - GUI will be needed.
	- Design was meant to have scripting feature for repetitive test.
	
New
	- Redefine the purpose of the interface 
		○ To facilitate oscilloscope measurements for signal lines?
		○ Automate more and more portion of repetitive tests
    Q current measurements - eg, want to measure 100x, want to measure overnight etc

![image](https://github.com/TeamSlack/Relaybox/blob/1e74484e2be97cf95c3558820d5d0cdcbf312b78/GUI.png)

The test interface consists of relays configured in both Low Side and High Side switches which can be selected on the GUI.
The GUI also allows for loading of test sequences to automatically run tests.
