//
//  BMUnityPlugin.h
//  BoomVideoSDKLibrary
//
//  Created by Rahul on 13/12/14.
//  Copyright (c) 2014 BM. All rights reserved.
//
#ifndef BoomVideoSDKLibrary_BMUnityPlugin_h
#define BoomVideoSDKLibrary_BMUnityPlugin_h

#ifdef __cplusplus
extern "C" {
#endif
    
    void UnitySendMessage(const char* obj, const char* method, const char* msg);
    
#ifdef __cplusplus
}
#endif


#endif
void showPrerollView(char *boomGuid);
void showRewardView(char *boomGuid);
void showOfferlistView(char *boomGuid);
#import <Foundation/Foundation.h>

@interface BMUnityPlugin : NSObject

@end
