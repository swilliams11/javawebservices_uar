package mctx;

import java.util.Map;
import java.util.Set;
import javax.annotation.Resource;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.xml.ws.WebServiceContext;
import javax.xml.ws.handler.MessageContext;

@WebService
public class Echo {
    @Resource
    WebServiceContext wctx;

    @WebMethod
    public String echo(String in) {
	String out = "Echoing: " + in;

	// Hit the transport level to extract the HTTP headers.
	MessageContext mctx = wctx.getMessageContext();
	Map requestHeaders = (Map) mctx.get(MessageContext.HTTP_REQUEST_HEADERS);
	dump(requestHeaders, "");

	return out;
    }

    private void dump(Map map, String indent) {
	Set keys = map.keySet();
	for (Object key : keys) {
	    System.out.println(indent + key + " : " + map.get(key));
	    if (map.get(key) instanceof Map)
		dump((Map) map.get(key), indent += "  ");
	}
    }
}