import javax.security.auth.callback.Callback;
import javax.security.auth.callback.CallbackHandler;
import com.sun.xml.wss.impl.callback.PasswordCallback;
import com.sun.xml.wss.impl.callback.PasswordValidationCallback;
import com.sun.xml.wss.impl.callback.UsernameCallback;
import java.io.BufferedReader;
import java.io.InputStreamReader;

// For ease of testing, the username and password are 
// hard-wired in the handle method with local variables
// username and password. For production, the hard-wirings
// would be removed.
public class Prompter implements CallbackHandler {
    private String readLine() {
	String line = null;
	try {
	    line = new BufferedReader(new InputStreamReader(System.in)).readLine();
	}
	catch(Exception e) { throw new RuntimeException(e); }
	return line;
    }

    // Prompt for and read the username and the password.
    public void handle(Callback[ ] callbacks) {
	try {
	    for (int i = 0; i < callbacks.length; i++) {
		if (callbacks[i] instanceof UsernameCallback) {
		    UsernameCallback cb = (UsernameCallback) callbacks[i];
		    /* Disable for testing.
		    System.out.print("Username: ");
		    String username = readLine();
		    */
		    String username = "fred"; // hard-wire for testing
		    if (username != null) cb.setUsername(username);
		} 
		else if (callbacks[i] instanceof PasswordCallback) {
		    PasswordCallback cb = (PasswordCallback) callbacks[i];
		    /* Disable for testing
		    System.out.print("Password: ");
		    String password = readLine();
		    */
		    String password = "rockbed"; // hard-wire for testing
		    if (password != null) cb.setPassword(password);
		} 
	    }
	}
	catch(Exception e) { throw new RuntimeException(e); }
    }
}